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

    public class SearchPersonsReturnsByGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 希望搜索的人员库列表，上限10个。
        /// </summary>
        [JsonProperty("GroupIds")]
        public string[] GroupIds{ get; set; }

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
        /// 最多识别的人脸数目。默认值为1（仅检测图片中面积最大的那张人脸），最大值为10。
        /// MaxFaceNum用于，当输入的待识别图片包含多张人脸时，设定要搜索的人脸的数量。
        /// 例：输入的Image或Url中的图片包含多张人脸，设MaxFaceNum=5，则会识别图片中面积最大的5张人脸。
        /// </summary>
        [JsonProperty("MaxFaceNum")]
        public ulong? MaxFaceNum{ get; set; }

        /// <summary>
        /// 人脸长和宽的最小尺寸，单位为像素。默认为80。低于40将影响搜索精度。建议设置为80。
        /// </summary>
        [JsonProperty("MinFaceSize")]
        public ulong? MinFaceSize{ get; set; }

        /// <summary>
        /// 被检测到的人脸，对应最多返回的最相似人员数目。默认值为5，最大值为10。  
        /// 例，设MaxFaceNum为3，MaxPersonNumPerGroup为5，GroupIds长度为3，则最多可能返回3*5*3=45个人员。
        /// </summary>
        [JsonProperty("MaxPersonNumPerGroup")]
        public ulong? MaxPersonNumPerGroup{ get; set; }

        /// <summary>
        /// 图片质量控制。 
        /// 0: 不进行控制； 
        /// 1:较低的质量要求，图像存在非常模糊，眼睛鼻子嘴巴遮挡至少其中一种或多种的情况； 
        /// 2: 一般的质量要求，图像存在偏亮，偏暗，模糊或一般模糊，眉毛遮挡，脸颊遮挡，下巴遮挡，至少其中三种的情况； 
        /// 3: 较高的质量要求，图像存在偏亮，偏暗，一般模糊，眉毛遮挡，脸颊遮挡，下巴遮挡，其中一到两种的情况； 
        /// 4: 很高的质量要求，各个维度均为最好或最多在某一维度上存在轻微问题； 
        /// 默认 0。 
        /// 若图片质量不满足要求，则返回结果中会提示图片质量检测不符要求。
        /// </summary>
        [JsonProperty("QualityControl")]
        public ulong? QualityControl{ get; set; }

        /// <summary>
        /// 出参Score中，只有超过FaceMatchThreshold值的结果才会返回。默认为0。
        /// </summary>
        [JsonProperty("FaceMatchThreshold")]
        public float? FaceMatchThreshold{ get; set; }

        /// <summary>
        /// 是否返回人员具体信息。0 为关闭，1 为开启。默认为 0。其他非0非1值默认为0
        /// </summary>
        [JsonProperty("NeedPersonInfo")]
        public long? NeedPersonInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "MaxFaceNum", this.MaxFaceNum);
            this.SetParamSimple(map, prefix + "MinFaceSize", this.MinFaceSize);
            this.SetParamSimple(map, prefix + "MaxPersonNumPerGroup", this.MaxPersonNumPerGroup);
            this.SetParamSimple(map, prefix + "QualityControl", this.QualityControl);
            this.SetParamSimple(map, prefix + "FaceMatchThreshold", this.FaceMatchThreshold);
            this.SetParamSimple(map, prefix + "NeedPersonInfo", this.NeedPersonInfo);
        }
    }
}

