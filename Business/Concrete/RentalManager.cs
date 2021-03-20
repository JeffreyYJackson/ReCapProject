using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using Core.Utilities.Result.DataResult;
using Core.Utilities.Result.VoidResult;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }


        public IResult Add(Rental rental)
        {
            if (_rentalDal.GetAll(r=>r.CarId == rental.CarId && rental.ReturnDate == null).Count != 0)
            {
                return new ErrorResult(Messages.RentalUnavailable);
                
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
            

        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IResult Remove(Rental rental)
        {
            _rentalDal.Remove(rental);
            return new SuccessResult(Messages.RentalRemoved);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.Id == id), Messages.RentalListed);
        }
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }

        public IResult ReturnCar(int rentalId)
        {
            var rentalToReturn = _rentalDal.Get(r=>r.Id == rentalId && r.ReturnDate == null);
            rentalToReturn.ReturnDate = DateTime.Now;
            _rentalDal.Update(rentalToReturn);
            return new SuccessResult(Messages.RentalReturned);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(), Messages.RentalsListed);
        }
    }
}