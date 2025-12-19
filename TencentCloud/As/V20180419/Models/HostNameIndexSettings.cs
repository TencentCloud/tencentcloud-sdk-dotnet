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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostNameIndexSettings : AbstractModel
    {
        
        /// <summary>
        /// 是否开启实例主机名创建序号，默认不开启。取值范围：
        /// 
        /// TRUE：表示开启实例主机名创建序号
        /// FALSE：表示不开启实例主机名创建序号
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 初始序号。
        /// 序号固定位数 IndexLength 为默认值0时，取值范围为 [0, 99999999]。
        /// 序号固定位数 IndexLength 为 [1, 8] 时，取值范围为为 [0, 10^IndexLength-1]，最大值即为固定位数的最大数字。
        /// 当序号递增后超出取值范围时，扩容活动会失败。
        /// 
        /// 首次开启实例主机名称序号：默认值为 0。
        /// 非首次开启实例主机名称序号：若不指定该参数，沿用历史序号。
        /// 下调初始序号可能会造成伸缩组内实例主机名称序号重复。
        /// </summary>
        [JsonProperty("BeginIndex")]
        public ulong? BeginIndex{ get; set; }

        /// <summary>
        /// 实例主机名递增序号位数，默认为0，表示不指定序号位数。不指定序号时，采用默认值0。
        /// 取值范围：0-8，最大为整数8。
        /// 采用取值1-8时，会检查序号是否超过此序号位数的最大数字。
        /// 
        /// 假设设置为3，那么序号形如：001、002 ... 010、011 ... 100 ... 999，序号上限为999;
        /// 假设设置为0，对应的序号为1、2 ... 10、11 ... 100 ... 1000 ...10000 ... 99999999，序号上限为99999999。
        /// </summary>
        [JsonProperty("IndexLength")]
        public ulong? IndexLength{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "BeginIndex", this.BeginIndex);
            this.SetParamSimple(map, prefix + "IndexLength", this.IndexLength);
        }
    }
}

