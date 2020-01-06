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

    public class VerifyFaceResponse : AbstractModel
    {
        
        /// <summary>
        /// 给定的人脸图片与 PersonId 对应人脸的相似度。若 PersonId 下有多张人脸（Face），返回相似度最大的分数。
        /// 
        /// 不同算法版本返回的相似度分数不同。
        /// 若需要验证两张图片中人脸是否为同一人，3.0版本误识率千分之一对应分数为40分，误识率万分之一对应分数为50分，误识率十万分之一对应分数为60分。 一般超过50分则可认定为同一人。
        /// 2.0版本误识率千分之一对应分数为70分，误识率万分之一对应分数为80分，误识率十万分之一对应分数为90分。 一般超过80分则可认定为同一人。
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// 是否为同一人的判断。
        /// </summary>
        [JsonProperty("IsMatch")]
        public bool? IsMatch{ get; set; }

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
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "IsMatch", this.IsMatch);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

