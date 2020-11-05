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

namespace TencentCloud.Ims.V20200713.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LibDetail : AbstractModel
    {
        
        /// <summary>
        /// 序号
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 仅当Lable为Custom自定义关键词时有效，表示自定义库id
        /// </summary>
        [JsonProperty("LibId")]
        public string LibId{ get; set; }

        /// <summary>
        /// 仅当Lable为Custom自定义关键词时有效，表示自定义库名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LibName")]
        public string LibName{ get; set; }

        /// <summary>
        /// 图片ID
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 恶意标签，Normal：正常，Polity：涉政，Porn：色情，Illegal：违法，Abuse：谩骂，Terror：暴恐，Ad：广告，Custom：自定义图片
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 自定义标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// 命中的模型分值
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "LibId", this.LibId);
            this.SetParamSimple(map, prefix + "LibName", this.LibName);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "Score", this.Score);
        }
    }
}

