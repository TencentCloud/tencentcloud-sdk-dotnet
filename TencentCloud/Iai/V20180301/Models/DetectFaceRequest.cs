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

    public class DetectFaceRequest : AbstractModel
    {
        
        /// <summary>
        /// 最多处理的人脸数目。默认值为1（仅检测图片中面积最大的那张人脸），最大值为120。 
        /// 此参数用于控制处理待检测图片中的人脸个数，值越小，处理速度越快。
        /// </summary>
        [JsonProperty("MaxFaceNum")]
        public ulong? MaxFaceNum{ get; set; }

        /// <summary>
        /// 人脸长和宽的最小尺寸，单位为像素。
        /// 默认为40。建议不低于34。
        /// 低于MinFaceSize值的人脸不会被检测。
        /// </summary>
        [JsonProperty("MinFaceSize")]
        public ulong? MinFaceSize{ get; set; }

        /// <summary>
        /// 图片 base64 数据，base64 编码后大小不可超过5M。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 图片的 Url 。对应图片 base64 编码后大小不可超过5M。
        /// Url、Image必须提供一个，如果都提供，只使用 Url。  
        /// 图片存储于腾讯云的Url可保障更高下载速度和稳定性，建议图片存储于腾讯云。 
        /// 非腾讯云存储的Url速度和稳定性可能受一定影响。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 是否需要返回人脸属性信息（FaceAttributesInfo）。0 为不需要返回，1 为需要返回。默认为 0。 
        /// 非 1 值均视为不需要返回，此时 FaceAttributesInfo 不具备参考意义。  
        /// 最多返回面积最大的 5 张人脸属性信息，超过 5 张人脸（第 6 张及以后的人脸）的 FaceAttributesInfo 不具备参考意义。  
        /// 提取人脸属性信息较为耗时，如不需要人脸属性信息，建议关闭此项功能，加快人脸检测速度。
        /// </summary>
        [JsonProperty("NeedFaceAttributes")]
        public ulong? NeedFaceAttributes{ get; set; }

        /// <summary>
        /// 是否开启质量检测。0 为关闭，1 为开启。默认为 0。 
        /// 非 1 值均视为不进行质量检测。
        /// 最多返回面积最大的 30 张人脸质量分信息，超过 30 张人脸（第 31 张及以后的人脸）的 FaceQualityInfo不具备参考意义。  
        /// 建议：人脸入库操作建议开启此功能。
        /// </summary>
        [JsonProperty("NeedQualityDetection")]
        public ulong? NeedQualityDetection{ get; set; }

        /// <summary>
        /// 人脸识别服务所用的算法模型版本。目前入参支持 “2.0”和“3.0“ 两个输入。  
        /// 默认为"2.0"。 
        /// 不同算法模型版本对应的人脸识别算法不同，新版本的整体效果会优于旧版本，建议使用“3.0”版本。
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxFaceNum", this.MaxFaceNum);
            this.SetParamSimple(map, prefix + "MinFaceSize", this.MinFaceSize);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "NeedFaceAttributes", this.NeedFaceAttributes);
            this.SetParamSimple(map, prefix + "NeedQualityDetection", this.NeedQualityDetection);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
        }
    }
}

