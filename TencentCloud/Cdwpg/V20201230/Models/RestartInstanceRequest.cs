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

namespace TencentCloud.Cdwpg.V20201230.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestartInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例名称，例如“cdwpg-xxxx"
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 需要重启的节点类型么，gtm/cn/dn/fn
        /// </summary>
        [JsonProperty("NodeTypes")]
        public string[] NodeTypes{ get; set; }

        /// <summary>
        /// 需要重启的节点编号，指定重启节点
        /// </summary>
        [JsonProperty("NodeIds")]
        public string[] NodeIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "NodeTypes.", this.NodeTypes);
            this.SetParamArraySimple(map, prefix + "NodeIds.", this.NodeIds);
        }
    }
}

