import axios from 'axios';

const API_URL = 'http://localhost:5016/api'

export const getBusinessByCityAndCategory = async (city, category) => {
    try {
      const response = await axios.get(`${API_URL}/business/Filter?city=${city}&category=${category}`);
      return response.data;
    } catch (error) {
      console.error('Error fetching business:', error);
      throw error;
    }
  };

  export const getHousingUnitsByCity = async(city) => {
    try {
      const response = await axios.get(`${API_URL}/HousingUnits/${city}`);
      return response.data;
    } catch (error) {
      console.error('Error fetching business:', error);
      throw error;
    }
  }