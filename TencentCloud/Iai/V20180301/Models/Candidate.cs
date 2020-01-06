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

namespace TencentCloud.Iai.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Candidate : AbstractModel
    {
        
        /// <summary>
        /// 人员ID
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 人脸ID
        /// </summary>
        [JsonProperty("FaceId")]
        public string FaceId{ get; set; }

        /// <summary>
        /// 候选者的匹配得分。 
        /// 
        /// 1万大小人脸底库下，误识率百分之一对应分数为70分，误识率千分之一对应分数为80分，误识率万分之一对应分数为90分；
        /// 10万大小人脸底库下，误识率百分之一对应分数为80分，误识率千分之一对应分数为90分，误识率万分之一对应分数为100分；
        /// 30万大小人脸底库下，误识率百分之一对应分数为85分，误识率千分之一对应分数为95分。
        /// 
        /// 一般80分左右可适用大部分场景，建议分数不要超过90分。您可以根据实际情况选择合适的分数。
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// 人员名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PersonName")]
        public string PersonName{ get; set; }

        /// <summary>
        /// 人员性别
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Gender")]
        public long? Gender{ get; set; }

        /// <summary>
        /// 包含此人员的人员库及描述字段内容列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PersonGroupInfos")]
        public PersonGroupInfo[] PersonGroupInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "FaceId", this.FaceId);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "PersonName", this.PersonName);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamArrayObj(map, prefix + "PersonGroupInfos.", this.PersonGroupInfos);
        }
    }
}

