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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListTargetsForPolicyNode : AbstractModel
    {
        
        /// <summary>
        /// <p>scp账号uin或节点Id</p>
        /// </summary>
        [JsonProperty("Uin")]
        public ulong? Uin{ get; set; }

        /// <summary>
        /// <p>关联类型 1-节点关联 2-用户关联</p>
        /// </summary>
        [JsonProperty("RelatedType")]
        public ulong? RelatedType{ get; set; }

        /// <summary>
        /// <p>账号或者节点名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>绑定时间</p>
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// <p>目标对象所属的组织层级名称路径</p>
        /// </summary>
        [JsonProperty("NodePath")]
        public string[] NodePath{ get; set; }

        /// <summary>
        /// <p>对应的组织层级 ID 路径</p>
        /// </summary>
        [JsonProperty("NodePathIds")]
        public long?[] NodePathIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "RelatedType", this.RelatedType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamArraySimple(map, prefix + "NodePath.", this.NodePath);
            this.SetParamArraySimple(map, prefix + "NodePathIds.", this.NodePathIds);
        }
    }
}

