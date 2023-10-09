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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PythonSparkImage : AbstractModel
    {
        
        /// <summary>
        /// spark镜像唯一id
        /// </summary>
        [JsonProperty("SparkImageId")]
        public string SparkImageId{ get; set; }

        /// <summary>
        /// 集群小版本镜像id
        /// </summary>
        [JsonProperty("ChildImageVersionId")]
        public string ChildImageVersionId{ get; set; }

        /// <summary>
        /// spark镜像名称
        /// </summary>
        [JsonProperty("SparkImageVersion")]
        public string SparkImageVersion{ get; set; }

        /// <summary>
        /// spark镜像描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SparkImageId", this.SparkImageId);
            this.SetParamSimple(map, prefix + "ChildImageVersionId", this.ChildImageVersionId);
            this.SetParamSimple(map, prefix + "SparkImageVersion", this.SparkImageVersion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

