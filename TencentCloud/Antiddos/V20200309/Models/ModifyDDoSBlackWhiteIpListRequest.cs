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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDDoSBlackWhiteIpListRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 当前配置的黑白名单类型，取值black时表示黑名单；取值white时表示白名单
        /// </summary>
        [JsonProperty("OldIpType")]
        public string OldIpType{ get; set; }

        /// <summary>
        /// 当前配置的Ip段，包含ip与掩码
        /// </summary>
        [JsonProperty("OldIp")]
        public IpSegment OldIp{ get; set; }

        /// <summary>
        /// 修改后黑白名单类型，取值black时黑名单，取值white时白名单
        /// </summary>
        [JsonProperty("NewIpType")]
        public string NewIpType{ get; set; }

        /// <summary>
        /// 当前配置的Ip段，包含ip与掩码
        /// </summary>
        [JsonProperty("NewIp")]
        public IpSegment NewIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OldIpType", this.OldIpType);
            this.SetParamObj(map, prefix + "OldIp.", this.OldIp);
            this.SetParamSimple(map, prefix + "NewIpType", this.NewIpType);
            this.SetParamObj(map, prefix + "NewIp.", this.NewIp);
        }
    }
}

