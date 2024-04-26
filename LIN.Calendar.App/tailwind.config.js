/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["../**/*{html,razor,js,cs}", "D:/LIN Services/Components/LIN.Calendar.Shared/**/*{html,razor,js,cs}"],
    theme: {
        screens: {
            'sm': '640px',
            'md': '768px',
            'dl': '910px',
            'lg': '1024px',
            'xl': '1280px',
            '2xl': '1536px',
        },
        extend: {
            colors: {

                'current': {
                    '50': '#f5f3ff',
                    '100': '#ede9fe',
                    '200': '#ddd6fe',
                    '300': '#c4b5fd',
                    '400': '#a78bfa',
                    '500': '#8b5cf6',
                    '600': '#7c3aed',
                    '700': '#6d28d9',
                    '800': '#5b21b6',
                    '900': '#4c1d95',
                    '950': '#2e1065'
                }
            }
        },
    },
    plugins: [],
}