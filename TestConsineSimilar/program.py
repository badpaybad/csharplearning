# import cupy as cp

# data = cp.random.rand(5000, 2048).astype(cp.float32)
# query = cp.random.rand(2048).astype(cp.float32)

# dot_products = cp.dot(data, query)
# norms = cp.linalg.norm(data, axis=1) * cp.linalg.norm(query)
# cosine_similarities = dot_products / norms

# threshold = 0.8
# different_vectors = cp.where(cosine_similarities < threshold)[0]
# print(different_vectors)
import numpy as np
import time

def cosine_similarity(v1, v2):
    return np.dot(v1, v2) / (np.linalg.norm(v1) * np.linalg.norm(v2))

# Giả lập dữ liệu: 5000 vector, mỗi vector có 2048 phần tử
data = np.random.rand(10000, 2048).astype(np.float32)  
query = np.random.rand(2048).astype(np.float32)  # Vector cần so sánh

# Lấy top-N vector giống nhất (ví dụ: top-5)
N = 10
start_time = time.perf_counter()
# Tính cosine similarity hàng loạt
dot_products = np.dot(data, query)  # Tích vô hướng của từng vector với query
norms = np.linalg.norm(data, axis=1) * np.linalg.norm(query)  # Tính norm của từng vector
cosine_similarities = dot_products / norms  # Tính cosine similarity

top_N_indices = np.argsort(-cosine_similarities)[:N]  # Sắp xếp giảm dần và lấy top-N
top_N_values = cosine_similarities[top_N_indices]  # Lấy giá trị tương ứng

end_time = time.perf_counter()

elapsed_time_ms = (end_time - start_time) * 1000
print(f"Time elapsed: {elapsed_time_ms:.3f} ms")
# In ra các vector giống nhất
for i, idx in enumerate(top_N_indices):
    print(f"Top {i+1}: Index {idx}, Similarity {top_N_values[i]:.4f}")
