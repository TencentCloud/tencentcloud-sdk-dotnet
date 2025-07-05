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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AclConfig : AbstractModel
    {
        
        /// <summary>
        /// 协议类型, 可取值tcp, udp, all
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// 目的端口起始，可取值范围0~65535
        /// </summary>
        [JsonProperty("DPortStart")]
        public ulong? DPortStart{ get; set; }

        /// <summary>
        /// 目的端口结束，可取值范围0~65535
        /// </summary>
        [JsonProperty("DPortEnd")]
        public ulong? DPortEnd{ get; set; }

        /// <summary>
        /// 来源端口起始，可取值范围0~65535
        /// </summary>
        [JsonProperty("SPortStart")]
        public ulong? SPortStart{ get; set; }

        /// <summary>
        /// 来源端口结束，可取值范围0~65535
        /// </summary>
        [JsonProperty("SPortEnd")]
        public ulong? SPortEnd{ get; set; }

        /// <summary>
        /// 动作，可取值：drop， transmit， forward
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 策略优先级，数字越小，级别越高，该规则越靠前匹配，取值1-1000
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ForwardProtocol", this.ForwardProtocol);
            this.SetParamSimple(map, prefix + "DPortStart", this.DPortStart);
            this.SetParamSimple(map, prefix + "DPortEnd", this.DPortEnd);
            this.SetParamSimple(map, prefix + "SPortStart", this.SPortStart);
            this.SetParamSimple(map, prefix + "SPortEnd", this.SPortEnd);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
        }
    }
}

