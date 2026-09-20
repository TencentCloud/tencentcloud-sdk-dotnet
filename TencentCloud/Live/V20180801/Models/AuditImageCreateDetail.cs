/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditImageCreateDetail : AbstractModel
    {
        
        /// <summary>
        /// 图片上传状态，0 表示成功，其他表示失败。
        /// 10101: url 解码失败。
        /// 10102: url 解析失败。
        /// 10103: url 不是 cos 地址。
        /// 10301: label 不合法。
        /// 20101: 数据入库错误。
        /// 30101: cos 下载图片连接错误。
        /// 30102: cos 下载图片响应错误。
        /// 40101: 优图接口调用错误。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 上传的图片 Id。
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 图片上传顺序索引。
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "Index", this.Index);
        }
    }
}

