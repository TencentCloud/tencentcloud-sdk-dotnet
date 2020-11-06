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

namespace TencentCloud.Ape.V20200513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOrderAndPayRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片ID
        /// </summary>
        [JsonProperty("ImageId")]
        public ulong? ImageId{ get; set; }

        /// <summary>
        /// 授权人ID
        /// </summary>
        [JsonProperty("AuthUserId")]
        public string AuthUserId{ get; set; }

        /// <summary>
        /// 售卖组合id
        /// </summary>
        [JsonProperty("MarshalId")]
        public ulong? MarshalId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "AuthUserId", this.AuthUserId);
            this.SetParamSimple(map, prefix + "MarshalId", this.MarshalId);
        }
    }
}

