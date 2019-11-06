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

    public class SearchPersonsRequest : AbstractModel
    {
        
        /// <summary>
        /// 希望搜索的人员库列表，上限100个。
        /// </summary>
        [JsonProperty("GroupIds")]
        public string[] GroupIds{ get; set; }

        /// <summary>
        /// 图片 base64 数据，base64 编码后大小不可超过5M。
        /// 若图片中包含多张人脸，只选取其中人脸面积最大的人脸。
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
        /// 单张被识别的人脸返回的最相似人员数量。默认值为5，最大值为100。
        /// 例，设MaxFaceNum为1，MaxPersonNum为8，则返回Top8相似的人员信息。
        /// 值越大，需要处理的时间越长。建议不要超过10。
        /// </summary>
        [JsonProperty("MaxPersonNum")]
        public ulong? MaxPersonNum{ get; set; }

        /// <summary>
        /// 此参数用于控制判断 Image 或 Url 中图片包含的人脸，是否在人员库中已有疑似的同一人。 
        /// 如果判断为已有相同人在人员库中，则不会创建新的人员，返回疑似同一人的人员信息。 
        /// 如果判断没有，则完成创建人员。 
        /// 0: 不进行判断，无论是否有疑似同一人在库中均完成入库； 
        /// 1:较低的同一人判断要求（百一误识别率）； 
        /// 2: 一般的同一人判断要求（千一误识别率）； 
        /// 3: 较高的同一人判断要求（万一误识别率）； 
        /// 4: 很高的同一人判断要求（十万一误识别率）。 
        /// 默认 0。  
        /// 注： 要求越高，则疑似同一人的概率越小。不同要求对应的误识别率仅为参考值，您可以根据实际情况调整。
        /// </summary>
        [JsonProperty("QualityControl")]
        public ulong? QualityControl{ get; set; }

        /// <summary>
        /// 出参Score中，只有大于等于FaceMatchThreshold值的结果才会返回。默认为0。取值范围[0.0,100.0) 。
        /// </summary>
        [JsonProperty("FaceMatchThreshold")]
        public float? FaceMatchThreshold{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "MaxFaceNum", this.MaxFaceNum);
            this.SetParamSimple(map, prefix + "MinFaceSize", this.MinFaceSize);
            this.SetParamSimple(map, prefix + "MaxPersonNum", this.MaxPersonNum);
            this.SetParamSimple(map, prefix + "QualityControl", this.QualityControl);
            this.SetParamSimple(map, prefix + "FaceMatchThreshold", this.FaceMatchThreshold);
        }
    }
}

