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

    public class DetectFaceResponse : AbstractModel
    {
        
        /// <summary>
        /// 请求的图片宽度。
        /// </summary>
        [JsonProperty("ImageWidth")]
        public long? ImageWidth{ get; set; }

        /// <summary>
        /// 请求的图片高度。
        /// </summary>
        [JsonProperty("ImageHeight")]
        public long? ImageHeight{ get; set; }

        /// <summary>
        /// 人脸信息列表。包含人脸坐标信息、属性信息（若需要）、质量分信息（若需要）。
        /// </summary>
        [JsonProperty("FaceInfos")]
        public FaceInfo[] FaceInfos{ get; set; }

        /// <summary>
        /// 人脸识别服务所用的算法模型版本。
        /// 目前入参支持 “2.0”和“3.0“ 两个输入。
        /// 2020年4月2日开始，默认为“3.0”，之前使用过本接口的账号若未填写本参数默认为“2.0”。
        /// 2020年11月26日后开通服务的账号仅支持输入“3.0”。
        /// 不同算法模型版本对应的人脸识别算法不同，新版本的整体效果会优于旧版本，建议使用“3.0”版本。
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageWidth", this.ImageWidth);
            this.SetParamSimple(map, prefix + "ImageHeight", this.ImageHeight);
            this.SetParamArrayObj(map, prefix + "FaceInfos.", this.FaceInfos);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

