using AutoMapper;
using Example002_MapFlattening;
using Example002_MapFlattening.DTOs;
using Example002_MapFlattening.Profiles;
using System;
using Xunit;

namespace Example002_MapFlatteningTests
{
    public class UserProfileTests
    {
        [Fact]
        public void MapUser_ShouldReturnUserDtoFlattened()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<UserProfile>();
            });

            config.AssertConfigurationIsValid();

            var user = new User
            {
                Id = 5,
                Details = new UserDetails
                {
                    Address = "some_address"
                }
            };

            var mapper = config.CreateMapper();
            var userDto = mapper.Map<User, UserDto>(user);

            Assert.NotNull(userDto);
            Assert.Equal(5, userDto.Id);
            Assert.Equal("some_address", userDto.Address);
        }
    }
}
