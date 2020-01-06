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

    public class FaceFusionRequest : AbstractModel
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
        /// 图片 base64 数据。请确保人脸为正脸，无旋转。若某些手机拍摄后人脸被旋转，请使用图片的 EXIF 信息对图片进行旋转处理；请勿在 base64 数据中包含头部，如“data:image/jpeg;base64,”。
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 返回图像方式（url 或 base64) ，二选一。url有效期为30天。
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }

        /// <summary>
        /// 历史遗留字段，无需填写。因为融合只需提取人脸特征，不需要鉴黄。
        /// </summary>
        [JsonProperty("PornDetect")]
        public long? PornDetect{ get; set; }

        /// <summary>
        /// 0表示不需要鉴政，1表示需要鉴政。默认值为0。
        /// </summary>
        [JsonProperty("CelebrityIdentify")]
        public long? CelebrityIdentify{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "RspImgType", this.RspImgType);
            this.SetParamSimple(map, prefix + "PornDetect", this.PornDetect);
            this.SetParamSimple(map, prefix + "CelebrityIdentify", this.CelebrityIdentify);
        }
    }
}

