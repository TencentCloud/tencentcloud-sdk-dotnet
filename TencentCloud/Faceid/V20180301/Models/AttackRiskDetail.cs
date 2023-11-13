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

    public class AttackRiskDetail : AbstractModel
    {
        
        /// <summary>
        /// 疑似的攻击痕迹类型
        /// SuspectedSpoofingAttack：翻拍攻击
        /// SuspectedSynthesisImage：疑似合成图片
        /// SuspectedSynthesisVideo：疑似合成视频
        /// SuspectedeAnomalyAttack：人脸特征疑似非真人
        /// SuspectedAdversarialAttack：疑似对抗样本攻击
        /// SuspectedBlackIndustry：疑似黑产攻击
        /// SuspectedWatermark：疑似存在水印
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

