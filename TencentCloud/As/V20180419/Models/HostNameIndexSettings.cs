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
        /// 初始序号。取值范围与 IndexLength 参数有关：
        /// - IndexLength 为 0 时，取值范围为 [0, 99999999]。
        /// - IndexLength 为 [1, 8] 时，取值范围为为 [0, 10^IndexLength-1]，最大值即为指定位数的最大数字。
        /// 初始序号默认值如下：
        /// - 首次启用递增序号：初始序号默认值为 0 （ 展示位数与 IndexLength 有关，例如 IndexLength 为  4，展示值为 0000）
        /// - 非首次开启递增序号：顺延之前的递增序号，例如上次使用递增至序号 069，则新的初始序号默认值为 070。
        /// 注意：修改初始序号可能会造成伸缩组内序号重复。
        /// </summary>
        [JsonProperty("BeginIndex")]
        public ulong? BeginIndex{ get; set; }

        /// <summary>
        /// 递增序号长度，默认为0，表示不指定序号长度。 取值范围：0-8，最大为整数8。 
        /// - 长度设置为3，序号展示形式为：000、001、002 ... 010、011 ... 100 ... 999，序号上限为999
        /// - 长度设置为0，序号展示形式为：0、1、2 ... 10、11 ... 100 ... 1000 ...10000 ... 99999999，序号上限为99999999
        /// 注意：递增序号持续超出上限会导致扩容失败，请不要设置过小的递增序号长度。
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

