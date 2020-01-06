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

namespace TencentCloud.Bmlb.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTrafficMirrorsRequest : AbstractModel
    {
        
        /// <summary>
        /// 流量镜像实例ID的数组，支持批量查询
        /// </summary>
        [JsonProperty("TrafficMirrorIds")]
        public string[] TrafficMirrorIds{ get; set; }

        /// <summary>
        /// 流量镜像实例别名数组。
        /// </summary>
        [JsonProperty("Aliases")]
        public string[] Aliases{ get; set; }

        /// <summary>
        /// 流量镜像实例所属的私有网络ID数组，形如：vpc-xxx。
        /// </summary>
        [JsonProperty("VpcIds")]
        public string[] VpcIds{ get; set; }

        /// <summary>
        /// 分页的偏移量，也即从第几条记录开始查询
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 单次查询返回的条目数，默认值：500。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TrafficMirrorIds.", this.TrafficMirrorIds);
            this.SetParamArraySimple(map, prefix + "Aliases.", this.Aliases);
            this.SetParamArraySimple(map, prefix + "VpcIds.", this.VpcIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

