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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectAIFakeFacesRequest : AbstractModel
    {
        
        /// <summary>
        /// 传入需要检测的人脸图片或人脸视频（当前仅支持单人脸检测），使用base64编码的形式，如您的场景视频和图片都有，我们更建议您使用视频进行检测，为了提供更好的检测效果，请您注意以下输入数据的限制与建议：
        /// 
        /// - 图片的Base64值：
        /// 建议整体图像480x640的分辨率，脸部大小在 100X100 以上，由手机前置摄像头拍摄。
        /// Base64编码后的图片数据大小建议不超过3M、最大不可超过10M，仅支持jpg、png格式。
        /// 请使用标准的Base64编码方式(带=补位)，编码规范参考RFC4648。
        /// 
        /// - 视频的Base64值：
        /// Base64编码后的大小建议在8M以内、最大不可超过10M，支持mp4、avi、flv格式，由手机前置摄像头拍摄。
        /// 视频建议时长为2～5s，最大不可超过20s。
        /// 视频分辨率建议为480x640（最大支持720p），帧率在25fps~30fps之间。
        /// 请使用标准的Base64编码方式(带=补位)，编码规范参考RFC4648。
        /// 
        /// 若您未使用Encryption进行加密传输，则本字段为必填参数。
        /// </summary>
        [JsonProperty("FaceInput")]
        public string FaceInput{ get; set; }

        /// <summary>
        /// 传入的类型。
        /// - 取值范围：
        /// 1：传入的是图片类型。
        /// 2：传入的是视频类型。
        /// 其他：返回错误码InvalidParameter。
        /// 
        /// 若您未使用Encryption进行加密传输，则本字段为必填参数。
        /// </summary>
        [JsonProperty("FaceInputType")]
        public long? FaceInputType{ get; set; }

        /// <summary>
        /// 是否需要对请求信息进行全包体加密。
        /// - 支持的加密算法:AES-256-CBC、SM4-GCM。
        /// - 有加密需求的用户可使用此参数，详情请点击左侧链接。
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }

        /// <summary>
        /// 加密后的密文。
        /// - 加密前的数据格式如下:{"FaceInput":"AAAAA","FaceInputType":1}。
        /// </summary>
        [JsonProperty("EncryptedBody")]
        public string EncryptedBody{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FaceInput", this.FaceInput);
            this.SetParamSimple(map, prefix + "FaceInputType", this.FaceInputType);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
            this.SetParamSimple(map, prefix + "EncryptedBody", this.EncryptedBody);
        }
    }
}

