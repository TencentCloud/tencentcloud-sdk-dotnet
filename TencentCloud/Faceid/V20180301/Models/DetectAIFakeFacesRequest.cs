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

    public class DetectAIFakeFacesRequest : AbstractModel
    {
        
        /// <summary>
        /// 传入需要进行检测的带有人脸的图片或视频，使用base64编码的形式。
        /// 
        /// 图片的Base64值：
        /// 建议整体图像480x640的分辨率，脸部 大小 100X100 以上；
        /// Base64编码后的图片数据大小不超过3M，仅支持jpg、png格式。请使用标准的Base64编码方式(带=补位)，编码规范参考RFC4648。
        /// 
        /// 视频的Base64值：
        /// Base64编码后的大小不超过8M，支持mp4、avi、flv格式。
        /// 请使用标准的Base64编码方式(带=补位)，编码规范参考RFC4648。
        /// </summary>
        [JsonProperty("FaceInput")]
        public string FaceInput{ get; set; }

        /// <summary>
        /// 传入的类型
        /// 1- 传入的是图片类型
        /// 2- 传入的是视频类型
        /// 其他 - 返回错误码InvalidParameter
        /// </summary>
        [JsonProperty("FaceInputType")]
        public long? FaceInputType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FaceInput", this.FaceInput);
            this.SetParamSimple(map, prefix + "FaceInputType", this.FaceInputType);
        }
    }
}

