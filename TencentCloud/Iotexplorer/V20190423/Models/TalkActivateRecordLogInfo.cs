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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TalkActivateRecordLogInfo : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 激活时间，秒级时间戳
        /// </summary>
        [JsonProperty("ActiveTime")]
        public long? ActiveTime{ get; set; }

        /// <summary>
        /// 过期时间，秒级时间戳
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// TWeTalk类型：1-基础版；2-高级版；3-多模态；
        /// </summary>
        [JsonProperty("ServiceType")]
        public long? ServiceType{ get; set; }

        /// <summary>
        /// 状态: 0-未激活, 1-已激活, 2-已过期, 3-已作废
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ActiveTime", this.ActiveTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
        }
    }
}

