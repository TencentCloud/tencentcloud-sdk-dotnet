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

    public class CreatePersonResponse : AbstractModel
    {
        
        /// <summary>
        /// 人脸图片唯一标识。
        /// </summary>
        [JsonProperty("FaceId")]
        public string FaceId{ get; set; }

        /// <summary>
        /// 检测出的人脸框的位置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FaceRect")]
        public FaceRect FaceRect{ get; set; }

        /// <summary>
        /// 疑似同一人的PersonId。 
        /// 当 UniquePersonControl 参数不为0且人员库中有疑似的同一人，此参数才有意义。
        /// </summary>
        [JsonProperty("SimilarPersonId")]
        public string SimilarPersonId{ get; set; }

        /// <summary>
        /// 人脸识别所用的算法模型版本。
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FaceId", this.FaceId);
            this.SetParamObj(map, prefix + "FaceRect.", this.FaceRect);
            this.SetParamSimple(map, prefix + "SimilarPersonId", this.SimilarPersonId);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

