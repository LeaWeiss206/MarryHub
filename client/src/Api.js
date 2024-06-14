import axios from 'axios';

const API_URL = 'http://localhost:5016/api'; // שנה את הכתובת בהתאם לכתובת השרת שלך

export const getCities = async () => {
  try {
    const response = await axios.get(`${API_URL}/cities`);
    return response.data;
  } catch (error) {
    console.error('Error fetching items:', error);
    throw error;
  }
};

export const getCategories = async () => {
  try {
    const response = await axios.get(`${API_URL}/Categories`);
    return response.data;
  } catch (error) {
    console.error('Error fetching items:', error);
    throw error;
  }
};

export const getBusiness = async () => {
  try {
    const response = await axios.get(`${API_URL}/Business`);
    return response.data;
  } catch (error) {
    console.error('Error fetching items:', error);
    throw error;
  }
};




