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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UnHandleEvent : AbstractModel
    {
        
        /// <summary>
        /// 伪攻击链类型
        /// </summary>
        [JsonProperty("EventTableListStruct")]
        public UnHandleEventDetail[] EventTableListStruct{ get; set; }

        /// <summary>
        /// 1 是  0否
        /// </summary>
        [JsonProperty("BaseLineUser")]
        public ulong? BaseLineUser{ get; set; }

        /// <summary>
        /// 1 打开 0 关闭
        /// </summary>
        [JsonProperty("BaseLineInSwitch")]
        public ulong? BaseLineInSwitch{ get; set; }

        /// <summary>
        /// 1 打开 0 关闭
        /// </summary>
        [JsonProperty("BaseLineOutSwitch")]
        public ulong? BaseLineOutSwitch{ get; set; }

        /// <summary>
        /// vpc间防火墙实例数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcFwCount")]
        public ulong? VpcFwCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "EventTableListStruct.", this.EventTableListStruct);
            this.SetParamSimple(map, prefix + "BaseLineUser", this.BaseLineUser);
            this.SetParamSimple(map, prefix + "BaseLineInSwitch", this.BaseLineInSwitch);
            this.SetParamSimple(map, prefix + "BaseLineOutSwitch", this.BaseLineOutSwitch);
            this.SetParamSimple(map, prefix + "VpcFwCount", this.VpcFwCount);
        }
    }
}

