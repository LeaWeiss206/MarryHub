import { getCities, getCategories } from "./Api";
import React, { useEffect, useState } from 'react';
import { getBusinessByCityAndCategory, getHousingUnitsByCity } from "./businessApi";

export default function Home() 
{
    const [cities, setCities] = useState([]);
    const [categories, setCategories] = useState([]);
    const [business, setBusiness] = useState([]);
    const [selectedCity, setSelectedCity] = useState('');
    const [selectedCategory, setSelectedCategory] = useState('');
    
    useEffect(() => {
        const fetchData = async () => {
            try {
                const result1 = await getCities();
                setCities(result1);
                const result2 = await getCategories();
                setCategories(result2);

            } catch (error) {
                console.error('Error fetching items:', error);
            }
        };

        fetchData();
    }, []);
    const handleCityChange = (event) => {
        setSelectedCity(event.target.value);
    };

    const handleCategoryChange = (event) => {
        setSelectedCategory(event.target.value);
    };

    useEffect(() => {
        const fetchBusiness = async () => {
            if (selectedCity && selectedCategory) {
                try {
                    debugger
                    let result;
                    if (selectedCategory === "16") {
                      
                        result = await getHousingUnitsByCity(selectedCity);
                    } else {
                        result = await getBusinessByCityAndCategory(selectedCity, selectedCategory);
                    }
                    setBusiness(result);
                } catch (error) {
                    console.error('Error fetching business:', error);
                }
            }
        };
        
        fetchBusiness();
    }, [selectedCity, selectedCategory]);


    return (
        <>
            <div>
                <h2>בחירת עיר</h2>
                <select value={selectedCity} onChange={handleCityChange}>
                    <option value="">בחר עיר</option>
                    {cities.map((city, index) => (
                        <option key={index} value={city.id}>{city.name}</option>
                    ))}
                </select>
            </div>
            <div>
                <h2>בחירת קטגוריה</h2>
                <select value={selectedCategory} onChange={handleCategoryChange}>
                    <option value="">בחר קטגוריה</option>
                    {categories.map((category, index) => (
                        <option key={index} value={category.id}>{category.name}</option>
                    ))}
                </select>
            </div>
            <div>
                <h2>{selectedCategory === "16" ? "יחידות דיור" : "עסקים"}</h2>
                <ul>
                    { selectedCategory !== "16"? business.map((item, index) => (
                        <li key={index}>{item.name}</li>
                    )): business.map((item, index) => (
                        <li key={index}></li>
                    ))}
                </ul>
            </div>
        </>
    );
    
}