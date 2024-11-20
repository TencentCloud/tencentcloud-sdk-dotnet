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

namespace TencentCloud.Facefusion.V20220927.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FusionUltraParam : AbstractModel
    {
        
        /// <summary>
        /// 拉脸强度。主要用于调整生成结果人脸脸型更像素材模板还是用户人脸。取值越大越像用户人脸。
        /// 取值范围：0-1之间。默认取值0.7。
        /// 
        /// 该参数仅对SwapModelType（模型类型）取值1-5生效
        /// </summary>
        [JsonProperty("WarpRadio")]
        public float? WarpRadio{ get; set; }

        /// <summary>
        /// 人脸增强强度。对整个人脸进行增强，增加清晰度，改善质量。当生成的人脸不够清晰，质感不够好的时候可以设置。取值越大增强强度越大。
        /// 取值范围：0-1之间。默认取值1。
        /// 
        /// 该参数仅对SwapModelType（模型类型）取值1-5生效
        /// </summary>
        [JsonProperty("EnhanceRadio")]
        public float? EnhanceRadio{ get; set; }

        /// <summary>
        /// 磨皮强度。当生成脸的图像面部显脏时，可进行设置。
        /// 取值范围：0-1之间。默认取值1。
        /// 
        /// 该参数仅对SwapModelType（模型类型）取值1-5生效
        /// </summary>
        [JsonProperty("MpRadio")]
        public float? MpRadio{ get; set; }

        /// <summary>
        /// 人脸模糊开关（暂不支持）
        /// 当生成人脸比较清晰时，将人脸模糊到接近模板的清晰度的程度
        /// 
        /// 该参数仅对SwapModelType（模型类型）取值1-5生效
        /// </summary>
        [JsonProperty("BlurRadio")]
        public float? BlurRadio{ get; set; }

        /// <summary>
        /// 牙齿增强开关，默认取值为1
        /// 牙齿增强，修复牙齿。当生成牙齿不好（如牙齿裂开）可以打开此开关
        /// 0：牙齿增强关闭
        /// 1：牙齿增强打开
        /// 该参数仅对SwapModelType（模型类型）取值1-5生效
        /// </summary>
        [JsonProperty("TeethEnhanceRadio")]
        public float? TeethEnhanceRadio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WarpRadio", this.WarpRadio);
            this.SetParamSimple(map, prefix + "EnhanceRadio", this.EnhanceRadio);
            this.SetParamSimple(map, prefix + "MpRadio", this.MpRadio);
            this.SetParamSimple(map, prefix + "BlurRadio", this.BlurRadio);
            this.SetParamSimple(map, prefix + "TeethEnhanceRadio", this.TeethEnhanceRadio);
        }
    }
}

