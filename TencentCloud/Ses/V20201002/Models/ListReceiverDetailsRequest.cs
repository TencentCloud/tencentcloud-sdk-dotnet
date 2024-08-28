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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListReceiverDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// 收件人列表ID,CreateReceiver接口创建收件人列表时会返回该值
        /// </summary>
        [JsonProperty("ReceiverId")]
        public ulong? ReceiverId{ get; set; }

        /// <summary>
        /// 偏移量，整型，从0开始
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 限制数目，整型,不超过100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 收件人地址，长度0-50，示例：xxx@te.com，支持模糊查询
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 搜索开始时间
        /// </summary>
        [JsonProperty("CreateTimeBegin")]
        public string CreateTimeBegin{ get; set; }

        /// <summary>
        /// 搜索结束时间
        /// </summary>
        [JsonProperty("CreateTimeEnd")]
        public string CreateTimeEnd{ get; set; }

        /// <summary>
        /// 1:有效，2:无效
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReceiverId", this.ReceiverId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "CreateTimeBegin", this.CreateTimeBegin);
            this.SetParamSimple(map, prefix + "CreateTimeEnd", this.CreateTimeEnd);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

