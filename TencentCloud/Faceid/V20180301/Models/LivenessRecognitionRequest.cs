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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LivenessRecognitionRequest : AbstractModel
    {
        
        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// 姓名。中文请使用UTF-8编码。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 用于活体检测的视频，视频的BASE64值；
        /// BASE64编码后的大小不超过5M，支持mp4、avi、flv格式。
        /// </summary>
        [JsonProperty("VideoBase64")]
        public string VideoBase64{ get; set; }

        /// <summary>
        /// 活体检测类型，取值：LIP/ACTION/SILENT。
        /// LIP为数字模式，ACTION为动作模式，SILENT为静默模式，三种模式选择一种传入。
        /// </summary>
        [JsonProperty("LivenessType")]
        public string LivenessType{ get; set; }

        /// <summary>
        /// 数字模式传参：数字验证码(1234)，需先调用接口获取数字验证码；
        /// 动作模式传参：传动作顺序(2,1 or 1,2)，需先调用接口获取动作顺序；
        /// 静默模式传参：空。
        /// </summary>
        [JsonProperty("ValidateData")]
        public string ValidateData{ get; set; }

        /// <summary>
        /// 本接口不需要传递此参数。
        /// </summary>
        [JsonProperty("Optional")]
        public string Optional{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "VideoBase64", this.VideoBase64);
            this.SetParamSimple(map, prefix + "LivenessType", this.LivenessType);
            this.SetParamSimple(map, prefix + "ValidateData", this.ValidateData);
            this.SetParamSimple(map, prefix + "Optional", this.Optional);
        }
    }
}

