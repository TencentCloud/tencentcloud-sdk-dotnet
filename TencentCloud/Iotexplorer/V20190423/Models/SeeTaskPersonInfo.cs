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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SeeTaskPersonInfo : AbstractModel
    {
        
        /// <summary>
        /// 该人员在任务中的人脸列表
        /// </summary>
        [JsonProperty("Faces")]
        public SeeTaskFaceInfo[] Faces{ get; set; }

        /// <summary>
        /// 是否已标记为持久记忆
        /// </summary>
        [JsonProperty("IsRemembered")]
        public bool? IsRemembered{ get; set; }

        /// <summary>
        /// 人员名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 人员 ID
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 创建来源。0：自动识别；1：用户创建
        /// </summary>
        [JsonProperty("Source")]
        public ulong? Source{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Faces.", this.Faces);
            this.SetParamSimple(map, prefix + "IsRemembered", this.IsRemembered);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
        }
    }
}

