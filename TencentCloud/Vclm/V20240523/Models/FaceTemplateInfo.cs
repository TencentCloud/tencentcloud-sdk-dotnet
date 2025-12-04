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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// 角色ID。需要与MergeInfos中的TemplateFaceID依次对应。需要填数字，建议填"0"、"1"，依次累加。
        /// </summary>
        [JsonProperty("TemplateFaceID")]
        public string TemplateFaceID{ get; set; }

        /// <summary>
        /// 视频模板中要替换的人脸图片
        /// </summary>
        [JsonProperty("TemplateFaceImage")]
        public Image TemplateFaceImage{ get; set; }

        /// <summary>
        /// 视频模板中要替换的人脸图片的人脸框。不填默认取要替换的人脸图片中最大人脸。
        /// </summary>
        [JsonProperty("TemplateFaceRect")]
        public FaceRect TemplateFaceRect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateFaceID", this.TemplateFaceID);
            this.SetParamObj(map, prefix + "TemplateFaceImage.", this.TemplateFaceImage);
            this.SetParamObj(map, prefix + "TemplateFaceRect.", this.TemplateFaceRect);
        }
    }
}

