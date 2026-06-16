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

namespace TencentCloud.Dbdc.V20201029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBCustomNodeTagsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>DB Custom 节点ID</p><p>参数格式：dbcn-0zan5xxk</p>
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>为节点绑定的标签信息</p><p>入参限制：参考标签侧的限制</p>
        /// </summary>
        [JsonProperty("AddTags")]
        public Tag[] AddTags{ get; set; }

        /// <summary>
        /// <p>需要删除的标签Key</p>
        /// </summary>
        [JsonProperty("DeleteTagKeys")]
        public string[] DeleteTagKeys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamArrayObj(map, prefix + "AddTags.", this.AddTags);
            this.SetParamArraySimple(map, prefix + "DeleteTagKeys.", this.DeleteTagKeys);
        }
    }
}

