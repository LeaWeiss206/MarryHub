import React, { useEffect, useState } from 'react';
import {  getCities } from './Api';

export default function Cities() {

    const [items, setItems] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            try {
                debugger
                const result = await getCities();
                setItems(result);
            } catch (error) {
                console.error('Error fetching items:', error);
            }
        };

        fetchData();
    }, []);

    return (
        <div>
              
            <h1>Cities</h1>
            <ul>
          
                {items.map(item => (
                 
                    <li key={item.id}> {item.id}.{item.name}</li>
                ))}
            </ul>
        </div>
    );
}
