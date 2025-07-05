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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Filter : AbstractModel
    {
        
        /// <summary>
        /// 需要过滤的字段。过滤条件数量限制为10。
        /// Name可选值：VpcId, SubnetId, ClsTopicId, ClsLogsetId, Role, CfsId, CfsMountInsId, Eip；Values 长度限制为1。
        /// Name可选值：Status, Runtime, FunctionType, PublicNetStatus, AsyncRunEnable, TraceEnable；Values 长度限制为20。
        /// 当 Name = Runtime 时，CustomImage 表示过滤镜像类型函数。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 字段的过滤值。
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

