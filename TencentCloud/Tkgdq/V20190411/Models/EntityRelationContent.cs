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

namespace TencentCloud.Tkgdq.V20190411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EntityRelationContent : AbstractModel
    {
        
        /// <summary>
        /// 实体关系查询返回关系的object
        /// </summary>
        [JsonProperty("Object")]
        public EntityRelationObject[] Object{ get; set; }

        /// <summary>
        /// 实体关系查询返回关系的subject
        /// </summary>
        [JsonProperty("Subject")]
        public EntityRelationSubject[] Subject{ get; set; }

        /// <summary>
        /// 实体关系查询返回的关系名称
        /// </summary>
        [JsonProperty("Relation")]
        public string Relation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Object.", this.Object);
            this.SetParamArrayObj(map, prefix + "Subject.", this.Subject);
            this.SetParamSimple(map, prefix + "Relation", this.Relation);
        }
    }
}

