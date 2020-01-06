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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPersonSampleRequest : AbstractModel
    {
        
        /// <summary>
        /// 人物 ID。
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 名称，长度限制：128 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 描述，长度限制：1024 个字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 人物应用场景，可选值：
        /// 1. Recognition：用于内容识别，等价于 Recognition.Face。
        /// 2. Review：用于内容审核，等价于 Review.Face。
        /// 3. All：用于内容识别、内容审核，等价于 1+2。
        /// </summary>
        [JsonProperty("Usages")]
        public string[] Usages{ get; set; }

        /// <summary>
        /// 人脸操作信息。
        /// </summary>
        [JsonProperty("FaceOperationInfo")]
        public AiSampleFaceOperation FaceOperationInfo{ get; set; }

        /// <summary>
        /// 标签操作信息。
        /// </summary>
        [JsonProperty("TagOperationInfo")]
        public AiSampleTagOperation TagOperationInfo{ get; set; }

        /// <summary>
        /// 点播[子应用](/document/product/266/14574) ID。如果要访问子应用中的资源，则将该字段填写为子应用 ID；否则无需填写该字段。
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "Usages.", this.Usages);
            this.SetParamObj(map, prefix + "FaceOperationInfo.", this.FaceOperationInfo);
            this.SetParamObj(map, prefix + "TagOperationInfo.", this.TagOperationInfo);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

