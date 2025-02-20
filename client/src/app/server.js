const express = require('express');
const app = express();
const port = 4200;

app.get('/api', (req, res) => {
    res.json({ message: 'Hello, World!' });
});

app.listen(port, () => {
    console.log(`Server running at http://localhost:${port}`);
});