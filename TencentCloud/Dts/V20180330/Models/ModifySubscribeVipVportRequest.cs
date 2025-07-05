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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySubscribeVipVportRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据订阅实例的ID
        /// </summary>
        [JsonProperty("SubscribeId")]
        public string SubscribeId{ get; set; }

        /// <summary>
        /// 指定目的子网，如果传此参数，DstIp必须在目的子网内
        /// </summary>
        [JsonProperty("DstUniqSubnetId")]
        public string DstUniqSubnetId{ get; set; }

        /// <summary>
        /// 目标IP，与DstPort至少传一个
        /// </summary>
        [JsonProperty("DstIp")]
        public string DstIp{ get; set; }

        /// <summary>
        /// 目标PORT，支持范围为：[1025-65535]
        /// </summary>
        [JsonProperty("DstPort")]
        public long? DstPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubscribeId", this.SubscribeId);
            this.SetParamSimple(map, prefix + "DstUniqSubnetId", this.DstUniqSubnetId);
            this.SetParamSimple(map, prefix + "DstIp", this.DstIp);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
        }
    }
}

