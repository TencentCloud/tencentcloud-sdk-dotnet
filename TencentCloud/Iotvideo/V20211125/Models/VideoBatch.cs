/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Iotvideo.V20211125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoBatch : AbstractModel
    {
        
        /// <summary>
        /// 批次ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 状态：1：待创建设备 2：创建中 3：已完成
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 设备前缀
        /// </summary>
        [JsonProperty("DevPre")]
        public string DevPre{ get; set; }

        /// <summary>
        /// 设备数量
        /// </summary>
        [JsonProperty("DevNum")]
        public ulong? DevNum{ get; set; }

        /// <summary>
        /// 已创建设备数量
        /// </summary>
        [JsonProperty("DevNumCreated")]
        public ulong? DevNumCreated{ get; set; }

        /// <summary>
        /// 批次下载地址
        /// </summary>
        [JsonProperty("BatchURL")]
        public string BatchURL{ get; set; }

        /// <summary>
        /// 创建时间。unix时间戳
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 修改时间。unix时间戳
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DevPre", this.DevPre);
            this.SetParamSimple(map, prefix + "DevNum", this.DevNum);
            this.SetParamSimple(map, prefix + "DevNumCreated", this.DevNumCreated);
            this.SetParamSimple(map, prefix + "BatchURL", this.BatchURL);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

