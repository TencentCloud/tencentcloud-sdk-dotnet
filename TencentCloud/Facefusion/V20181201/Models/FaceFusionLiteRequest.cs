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

namespace TencentCloud.Facefusion.V20181201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceFusionLiteRequest : AbstractModel
    {
        
        /// <summary>
        /// 活动 ID，请在人脸融合控制台查看。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 素材 ID，请在人脸融合控制台查看。
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 用户人脸图片、素材模板图的人脸位置信息。
        /// </summary>
        [JsonProperty("MergeInfos")]
        public MergeInfo[] MergeInfos{ get; set; }

        /// <summary>
        /// 返回图像方式（url 或 base64) ，二选一。默认url, url有效期为30天。
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }

        /// <summary>
        /// 请注意，鉴政服务开启后，您需要根据返回结果自行判断是否调整您的业务逻辑。例如提示您的用户图片非法，请更换图片。
        /// </summary>
        [JsonProperty("CelebrityIdentify")]
        public long? CelebrityIdentify{ get; set; }

        /// <summary>
        /// 算法引擎参数:  1）选脸版 - youturecreat; 2）优享版 - youtu1vN； 3）畅享版 - ptu； 4）随机 - ALL;  默认为活动选择的算法
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamArrayObj(map, prefix + "MergeInfos.", this.MergeInfos);
            this.SetParamSimple(map, prefix + "RspImgType", this.RspImgType);
            this.SetParamSimple(map, prefix + "CelebrityIdentify", this.CelebrityIdentify);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
        }
    }
}

