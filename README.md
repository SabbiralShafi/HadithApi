# Hadith Api

A simple API to fetch random hadith in the Bengali Language.

![GitHub Workflow Status (branch)](https://img.shields.io/github/workflow/status/pienteger/hadithapi/deploy-api/master?style=flat-square) [![GitHub issues](https://img.shields.io/github/issues/Pienteger/HadithApi?style=flat-square)](https://github.com/Pienteger/HadithApi/issues) [![GitHub forks](https://img.shields.io/github/forks/Pienteger/HadithApi?style=flat-square)](https://github.com/Pienteger/HadithApi/network) [![GitHub stars](https://img.shields.io/github/stars/Pienteger/HadithApi?style=flat-square)](https://github.com/Pienteger/HadithApi/stargazers)

## Doc

### Get All the Hadiths

The following endpoint fetches all the available hadiths.

```
https://hadithapi.azurewebsites.net/api/randomhadith
```

### Get a single Hadith

The following endpoint returns a single hadith in random order.

```
https://hadithapi.azurewebsites.net/api/randomhadith/single
```

### Sample Response

```
{
    "id": 0,
    "speaker": "আলক্বামাহ ইবনু ওয়াক্কাস আল-লায়সী (রহঃ)",
    "reference": "হাদিস নং ১",
    "book": "সহিহ বুখারী",
    "condition": "সহিহ হাদিস",
    "body": "‘আলক্বামাহ ইবনু ওয়াক্কাস আল-লায়সী (রহঃ) থেকে বর্ণিতঃ আমি ‘উমর ইব্‌নুল খাত্তাব (রাঃ)-কে মিম্বারের উপর দাঁড়িয়ে বলতে শুনেছিঃ আমি আল্লাহর রসূল (সাল্লাল্লাহু ‘আলাইহি ওয়া সাল্লাম)-কে বলতে শুনেছিঃ কাজ (এর প্রাপ্য হবে) নিয়ত অনুযায়ী। আর মানুষ তার নিয়ত অনুযায়ী প্রতিফল পাবে। তাই যার হিজরত হবে ইহকাল লাভের অথবা কোন মহিলাকে বিবাহ করার উদ্দেশ্যে- তবে তার হিজরত সে উদ্দেশ্যেই হবে, যে জন্যে, সে হিজরত করেছে।"
}
```

Head over to [HadithApi Doc](pienteger.com/apistack/hadithapi) to read the full documentation.

## Contribution

To add more hadiths to the list, just edit the hadith.json file.

Jazakallah Khairan.
