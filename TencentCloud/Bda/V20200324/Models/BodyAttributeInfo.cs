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

namespace TencentCloud.Bda.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BodyAttributeInfo : AbstractModel
    {
        
        /// <summary>
        /// 人体年龄信息。 
        /// AttributesType 不含 Age 或检测超过 5 个人体时，此参数仍返回，但不具备参考意义。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Age")]
        public Age Age{ get; set; }

        /// <summary>
        /// 人体是否挎包。 
        /// AttributesType 不含 Bag 或检测超过 5 个人体时，此参数仍返回，但不具备参考意义。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Bag")]
        public Bag Bag{ get; set; }

        /// <summary>
        /// 人体性别信息。 
        /// AttributesType 不含 Gender 或检测超过 5 个人体时，此参数仍返回，但不具备参考意义。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Gender")]
        public Gender Gender{ get; set; }

        /// <summary>
        /// 人体朝向信息。   
        /// AttributesType 不含 UpperBodyCloth 或检测超过 5 个人体时，此参数仍返回，但不具备参考意义。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Orientation")]
        public Orientation Orientation{ get; set; }

        /// <summary>
        /// 人体上衣属性信息。
        /// AttributesType 不含 Orientation 或检测超过 5 个人体时，此参数仍返回，但不具备参考意义。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpperBodyCloth")]
        public UpperBodyCloth UpperBodyCloth{ get; set; }

        /// <summary>
        /// 人体下衣属性信息。  
        /// AttributesType 不含 LowerBodyCloth 或检测超过 5 个人体时，此参数仍返回，但不具备参考意义。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LowerBodyCloth")]
        public LowerBodyCloth LowerBodyCloth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Age.", this.Age);
            this.SetParamObj(map, prefix + "Bag.", this.Bag);
            this.SetParamObj(map, prefix + "Gender.", this.Gender);
            this.SetParamObj(map, prefix + "Orientation.", this.Orientation);
            this.SetParamObj(map, prefix + "UpperBodyCloth.", this.UpperBodyCloth);
            this.SetParamObj(map, prefix + "LowerBodyCloth.", this.LowerBodyCloth);
        }
    }
}

