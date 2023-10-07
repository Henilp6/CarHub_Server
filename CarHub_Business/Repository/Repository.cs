﻿
            //_db.VillaNumbers.Include(u => u.Villa).ToList();
            this.dbSet = _db.Set<T>();

            if (includeProperties != null)
            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            if (filter != null)
                //skip0.take(5)
                //page number- 2     || page size -5
                //skip(5*(1)) take(5)
                query = query.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
        }

            dbSet.Remove(entity);
        public async Task RemoveRangeAsync(Expression<Func<T, bool>>? filter = null, bool tracked = true)
        {
            IQueryable<T> query = dbSet;
            if (!tracked)
            {
                query = query.AsNoTracking();
                //_db.AttachRange(entities);
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            _db.RemoveRange(query);
            await SaveAsync();
        }


        public async Task SaveAsync()