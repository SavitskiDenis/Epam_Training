using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class MyList <T> where T : IEquatable<T>
    {
       public T value {get; set;}
       public MyList <T> nextItem {get; set;}
       public int Length
       {
           get
           {
               int _length=1;
               MyList<T> _item= nextItem;
               while (_item!=null)
               {
                   _item = _item.nextItem;
                   _length++;
               }
               return _length;
           }
       }
       private int _maxNumberOfItems;

       public MyList(int _numberOfItems,T _value)
       {
           value = _value;
           _maxNumberOfItems = _numberOfItems;
       }

       public void Add(T _value)
       {
           if(Length+1<=_maxNumberOfItems)
           {
           MyList<T> _item = nextItem;
           MyList<T> _lastitem = this;
               while (_item != null)
               {
                   _lastitem = _item;
                   _item = _item.nextItem;
               }
               _lastitem.nextItem = new MyList<T>(_maxNumberOfItems,_value);
           }
           else
           {
               throw new ListException("Количество элементов не может привышать заданному значению");
           }
       }

       public static string Output(MyList<T> _list)
       {
           string _listString = _list.value.ToString()+"|";
           MyList<T> _item = _list.nextItem;
           while(_item!=null)
           {
               _listString += _item.value+"|";
               _item = _item.nextItem;
           }
           return _listString;

       }

       public bool Remove(T _value)
       {
           MyList<T> _listItem = this;
           MyList<T> _saveItem = this;
           int _countindex = 0;
           while (_listItem != null)
           {
               if (_listItem.value.Equals(_value))
              {
                  
                   if(_countindex==0)
                   {
                       value = nextItem.value;
                       nextItem = nextItem.nextItem;
                   }
                   else
                   {
                       _saveItem.nextItem = _listItem.nextItem;
                   }
                  return true;
              }
              else
              {
                  _saveItem = _listItem;
                  _listItem = _listItem.nextItem;
                  _countindex++;
              }
           }

           return false;
       }

       public int IndexOf(T _item)
       {
           int _index = 0;
           MyList<T> _listItem = this;
           while(_listItem!=null)
           {
               if(_listItem.value.Equals(_item))
               {
                   return _index;
               }
               else
               {
                   _index++;
                   _listItem = _listItem.nextItem;
               }
           }
           return -1;

       }

       public void Insert(int _index,T _value)
       {
           if(_index < Length && _index>=0)
           {
               int _countIndex=0;
               MyList<T> _listItem = this;
               while(_countIndex != _index)
               {
                   _listItem = _listItem.nextItem;
                   _countIndex++;
               }
               _listItem.value = _value;
           }
           else
           {
               throw new ListException("Не верный индекс");
           }
       }

       public void RemoveAt(int _index)
       {
           if(_index < Length  && _index>=0)
           {
               if (_index > 0)
               {
                   int _countIndex = 1;
                   MyList<T> _listItem = nextItem;
                   MyList<T> _saveItem = this;
                   while (_countIndex != _index)
                   {
                       _saveItem = _listItem;
                       _listItem = _listItem.nextItem;
                       _countIndex++;
                   }
                   _saveItem.nextItem = _listItem.nextItem;
               }
               else
               {
                   value = nextItem.value;
                   nextItem = nextItem.nextItem;
               }
               
           }
           else
           {
               throw new ListException("Не верный индекс");
           }
       }


    }

}
