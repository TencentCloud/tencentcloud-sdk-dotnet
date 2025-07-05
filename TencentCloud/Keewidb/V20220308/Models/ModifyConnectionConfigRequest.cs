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

namespace TencentCloud.Keewidb.V20220308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyConnectionConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，如：kee-6ubh****。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 单分片附加带宽，取值范围[0,512]，单位：MB。
        /// <ul><li>开启副本只读时，实例总带宽  = 单分片附加带宽 * 分片数 + 标准带宽 * 分片数 * Max ([只读副本数量, 1])，标准架构的分片数 = 1。</li><li>没有开启副本只读时，实例总带宽 = 单分片附加带宽 * 分片数 + 标准带宽 * 分片数，标准架构的分片数 = 1。</li></ul>
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 单分片的总连接数。
        /// <ul>默认为10000，整个实例的最大连接数为单个分片的最大连接数 x 分片数量。标准架构分片数量为1。
        /// <li>关闭副本只读：每个分片的最大连接数的取值范围为[10000,40000]。</li><li>开启副本只读：每个分片的最大连接数的取值范围为 [10000,10000 x (副本数 + 3)]。</li></ul>
        /// </summary>
        [JsonProperty("ClientLimit")]
        public long? ClientLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "ClientLimit", this.ClientLimit);
        }
    }
}

