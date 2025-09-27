/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["../**/*{html,razor,js,cs}", "D:/LIN/LIN Services/Components/LIN.Calendar.Shared/**/*{html,razor,js,cs}"],
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
                    '50': '#f4f6fb',
                    '100': '#e7edf7',
                    '200': '#cad8ed',
                    '300': '#9bb8de',
                    '400': '#6692ca',
                    '500': '#4275b5',
                    '600': '#315c98',
                    '700': '#294a7b',
                    '800': '#254067',
                    '900': '#233757',
                    '950': '#17233a'
                }
            }
        },
    },
    plugins: [],
}