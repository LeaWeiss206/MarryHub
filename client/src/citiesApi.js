import axios from 'axios';

const API_URL = 'http://localhost:5016/api'; // שנה את הכתובת בהתאם לכתובת השרת שלך

export const getItems = async () => {
  try {
    const response = await axios.get(`${API_URL}/cities`);
    return response.data;
  } catch (error) {
    console.error('Error fetching items:', error);
    throw error;
  }
};


