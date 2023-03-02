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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Fetus : AbstractModel
    {
        
        /// <summary>
        /// 双顶径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BPD")]
        public FieldInfo BPD{ get; set; }

        /// <summary>
        /// 腹前后径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("APTD")]
        public FieldInfo APTD{ get; set; }

        /// <summary>
        /// 腹左右径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TTD")]
        public FieldInfo TTD{ get; set; }

        /// <summary>
        /// 头臀径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CRL")]
        public FieldInfo CRL{ get; set; }

        /// <summary>
        /// 头围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HC")]
        public FieldInfo HC{ get; set; }

        /// <summary>
        /// 腹围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AC")]
        public FieldInfo AC{ get; set; }

        /// <summary>
        /// 股骨长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FL")]
        public FieldInfo FL{ get; set; }

        /// <summary>
        /// 肱骨长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HL")]
        public FieldInfo HL{ get; set; }

        /// <summary>
        /// 胎儿重量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Weight")]
        public FieldInfo Weight{ get; set; }

        /// <summary>
        /// 颈项透明层
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NT")]
        public FieldInfo NT{ get; set; }

        /// <summary>
        /// 脐动脉血流
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UmbilicalCord")]
        public FieldInfo UmbilicalCord{ get; set; }

        /// <summary>
        /// 羊水最大深度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaterDeep")]
        public FieldInfo WaterDeep{ get; set; }

        /// <summary>
        /// 羊水四象限测量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaterQuad")]
        public FieldInfo WaterQuad{ get; set; }

        /// <summary>
        /// 羊水指数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AFI")]
        public FieldInfo AFI{ get; set; }

        /// <summary>
        /// 胎心
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FHR")]
        public FieldInfo FHR{ get; set; }

        /// <summary>
        /// 胎动
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Movement")]
        public FieldInfo Movement{ get; set; }

        /// <summary>
        /// 胎数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Num")]
        public FieldInfo Num{ get; set; }

        /// <summary>
        /// 胎位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Position")]
        public FieldInfo Position{ get; set; }

        /// <summary>
        /// 是否活胎
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Alive")]
        public FieldInfo Alive{ get; set; }

        /// <summary>
        /// 胎盘位置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlacentaLocation")]
        public FieldInfo PlacentaLocation{ get; set; }

        /// <summary>
        /// 胎盘厚度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlacentaThickness")]
        public FieldInfo PlacentaThickness{ get; set; }

        /// <summary>
        /// 胎盘成熟度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlacentaGrade")]
        public FieldInfo PlacentaGrade{ get; set; }

        /// <summary>
        /// 妊娠时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GestationTime")]
        public FieldInfo GestationTime{ get; set; }

        /// <summary>
        /// 妊娠周期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GestationPeriod")]
        public FieldInfo GestationPeriod{ get; set; }

        /// <summary>
        /// 绕颈
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AroundNeck")]
        public FieldInfo AroundNeck{ get; set; }

        /// <summary>
        /// 病变
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sym")]
        public FieldInfo[] Sym{ get; set; }

        /// <summary>
        /// 原文内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Src")]
        public string Src{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BPD.", this.BPD);
            this.SetParamObj(map, prefix + "APTD.", this.APTD);
            this.SetParamObj(map, prefix + "TTD.", this.TTD);
            this.SetParamObj(map, prefix + "CRL.", this.CRL);
            this.SetParamObj(map, prefix + "HC.", this.HC);
            this.SetParamObj(map, prefix + "AC.", this.AC);
            this.SetParamObj(map, prefix + "FL.", this.FL);
            this.SetParamObj(map, prefix + "HL.", this.HL);
            this.SetParamObj(map, prefix + "Weight.", this.Weight);
            this.SetParamObj(map, prefix + "NT.", this.NT);
            this.SetParamObj(map, prefix + "UmbilicalCord.", this.UmbilicalCord);
            this.SetParamObj(map, prefix + "WaterDeep.", this.WaterDeep);
            this.SetParamObj(map, prefix + "WaterQuad.", this.WaterQuad);
            this.SetParamObj(map, prefix + "AFI.", this.AFI);
            this.SetParamObj(map, prefix + "FHR.", this.FHR);
            this.SetParamObj(map, prefix + "Movement.", this.Movement);
            this.SetParamObj(map, prefix + "Num.", this.Num);
            this.SetParamObj(map, prefix + "Position.", this.Position);
            this.SetParamObj(map, prefix + "Alive.", this.Alive);
            this.SetParamObj(map, prefix + "PlacentaLocation.", this.PlacentaLocation);
            this.SetParamObj(map, prefix + "PlacentaThickness.", this.PlacentaThickness);
            this.SetParamObj(map, prefix + "PlacentaGrade.", this.PlacentaGrade);
            this.SetParamObj(map, prefix + "GestationTime.", this.GestationTime);
            this.SetParamObj(map, prefix + "GestationPeriod.", this.GestationPeriod);
            this.SetParamObj(map, prefix + "AroundNeck.", this.AroundNeck);
            this.SetParamArrayObj(map, prefix + "Sym.", this.Sym);
            this.SetParamSimple(map, prefix + "Src", this.Src);
        }
    }
}

