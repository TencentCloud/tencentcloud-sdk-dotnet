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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceResult : AbstractModel
    {
        
        /// <summary>
        /// 检测出的人脸框位置。
        /// </summary>
        [JsonProperty("FaceRect")]
        public FaceRect FaceRect{ get; set; }

        /// <summary>
        /// 候选人列表。当前返回相似度最高的候选人。
        /// </summary>
        [JsonProperty("Candidates")]
        public Candidate[] Candidates{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FaceRect.", this.FaceRect);
            this.SetParamArrayObj(map, prefix + "Candidates.", this.Candidates);
        }
    }
}

