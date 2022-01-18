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

    public class ConnectLimitConfig : AbstractModel
    {
        
        /// <summary>
        /// 基于源IP+目的IP的每秒新建数限制
        /// </summary>
        [JsonProperty("SdNewLimit")]
        public ulong? SdNewLimit{ get; set; }

        /// <summary>
        /// 基于目的IP的每秒新建数限制
        /// </summary>
        [JsonProperty("DstNewLimit")]
        public ulong? DstNewLimit{ get; set; }

        /// <summary>
        /// 基于源IP+目的IP的并发连接控制
        /// </summary>
        [JsonProperty("SdConnLimit")]
        public ulong? SdConnLimit{ get; set; }

        /// <summary>
        /// 基于目的IP+目的端口的并发连接控制
        /// </summary>
        [JsonProperty("DstConnLimit")]
        public ulong? DstConnLimit{ get; set; }

        /// <summary>
        /// 基于连接抑制触发阈值，取值范围[0,4294967295]
        /// </summary>
        [JsonProperty("BadConnThreshold")]
        public ulong? BadConnThreshold{ get; set; }

        /// <summary>
        /// 异常连接检测条件，空连接防护开关，，取值范围[0,1]
        /// </summary>
        [JsonProperty("NullConnEnable")]
        public ulong? NullConnEnable{ get; set; }

        /// <summary>
        /// 异常连接检测条件，连接超时，，取值范围[0,65535]
        /// </summary>
        [JsonProperty("ConnTimeout")]
        public ulong? ConnTimeout{ get; set; }

        /// <summary>
        /// 异常连接检测条件，syn占比ack百分比，，取值范围[0,100]
        /// </summary>
        [JsonProperty("SynRate")]
        public ulong? SynRate{ get; set; }

        /// <summary>
        /// 异常连接检测条件，syn阈值，取值范围[0,100]
        /// </summary>
        [JsonProperty("SynLimit")]
        public ulong? SynLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdNewLimit", this.SdNewLimit);
            this.SetParamSimple(map, prefix + "DstNewLimit", this.DstNewLimit);
            this.SetParamSimple(map, prefix + "SdConnLimit", this.SdConnLimit);
            this.SetParamSimple(map, prefix + "DstConnLimit", this.DstConnLimit);
            this.SetParamSimple(map, prefix + "BadConnThreshold", this.BadConnThreshold);
            this.SetParamSimple(map, prefix + "NullConnEnable", this.NullConnEnable);
            this.SetParamSimple(map, prefix + "ConnTimeout", this.ConnTimeout);
            this.SetParamSimple(map, prefix + "SynRate", this.SynRate);
            this.SetParamSimple(map, prefix + "SynLimit", this.SynLimit);
        }
    }
}

