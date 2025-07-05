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

namespace TencentCloud.Iotvideo.V20211125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDataForwardRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品ID。
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 转发地址。如果有鉴权Token，则需要自行传入，例如 [{\"forward\":{\"api\":\"http://123.207.117.108:1080/sub.php\",\"token\":\"testtoken\"}}]
        /// </summary>
        [JsonProperty("ForwardAddr")]
        public string ForwardAddr{ get; set; }

        /// <summary>
        /// 1-数据信息转发 2-设备上下线状态转发 3-数据信息转发&设备上下线状态转发
        /// </summary>
        [JsonProperty("DataChose")]
        public long? DataChose{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ForwardAddr", this.ForwardAddr);
            this.SetParamSimple(map, prefix + "DataChose", this.DataChose);
        }
    }
}

