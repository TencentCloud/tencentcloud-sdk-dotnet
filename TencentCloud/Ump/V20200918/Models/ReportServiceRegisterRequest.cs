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

namespace TencentCloud.Ump.V20200918.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReportServiceRegisterRequest : AbstractModel
    {
        
        /// <summary>
        /// 集团编码
        /// </summary>
        [JsonProperty("GroupCode")]
        public string GroupCode{ get; set; }

        /// <summary>
        /// 广场ID
        /// </summary>
        [JsonProperty("MallId")]
        public ulong? MallId{ get; set; }

        /// <summary>
        /// 服务上报当前的服务能力信息
        /// </summary>
        [JsonProperty("ServiceRegisterInfos")]
        public ServiceRegisterInfo[] ServiceRegisterInfos{ get; set; }

        /// <summary>
        /// 服务内网Ip
        /// </summary>
        [JsonProperty("ServerIp")]
        public string ServerIp{ get; set; }

        /// <summary>
        /// 上报服务所在服务器的唯一ID
        /// </summary>
        [JsonProperty("ServerNodeId")]
        public string ServerNodeId{ get; set; }

        /// <summary>
        /// 上报时间戳, 单位毫秒
        /// </summary>
        [JsonProperty("ReportTime")]
        public long? ReportTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupCode", this.GroupCode);
            this.SetParamSimple(map, prefix + "MallId", this.MallId);
            this.SetParamArrayObj(map, prefix + "ServiceRegisterInfos.", this.ServiceRegisterInfos);
            this.SetParamSimple(map, prefix + "ServerIp", this.ServerIp);
            this.SetParamSimple(map, prefix + "ServerNodeId", this.ServerNodeId);
            this.SetParamSimple(map, prefix + "ReportTime", this.ReportTime);
        }
    }
}

