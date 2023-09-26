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

    public class ModifyEdgeIpSwitchRequest : AbstractModel
    {
        
        /// <summary>
        /// 0 关闭开关
        /// 1 打开开关
        /// 2 不操作开关，此次切换模式
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// 操作开关详情
        /// </summary>
        [JsonProperty("EdgeIpSwitchLst")]
        public EdgeIpSwitch[] EdgeIpSwitchLst{ get; set; }

        /// <summary>
        /// 0 不自动选择子网
        /// 1 自动选择子网创建私有连接
        /// </summary>
        [JsonProperty("AutoChooseSubnet")]
        public long? AutoChooseSubnet{ get; set; }

        /// <summary>
        /// 0 切换为旁路
        /// 1 切换为串行
        /// 2 不切换模式，此次操作开关
        /// </summary>
        [JsonProperty("SwitchMode")]
        public long? SwitchMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamArrayObj(map, prefix + "EdgeIpSwitchLst.", this.EdgeIpSwitchLst);
            this.SetParamSimple(map, prefix + "AutoChooseSubnet", this.AutoChooseSubnet);
            this.SetParamSimple(map, prefix + "SwitchMode", this.SwitchMode);
        }
    }
}

