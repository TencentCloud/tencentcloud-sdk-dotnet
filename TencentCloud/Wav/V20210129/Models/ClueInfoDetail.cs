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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClueInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// 线索id，线索唯一识别编码
        /// </summary>
        [JsonProperty("ClueId")]
        public string ClueId{ get; set; }

        /// <summary>
        /// 接待客户经销商顾问所属组织id,多个组织使用逗号分割
        /// </summary>
        [JsonProperty("DealerId")]
        public string DealerId{ get; set; }

        /// <summary>
        /// 线索获取时间，用户添加企业微信时间，单位是秒
        /// </summary>
        [JsonProperty("EnquireTime")]
        public ulong? EnquireTime{ get; set; }

        /// <summary>
        /// 客户在微信生态中唯一识别码
        /// </summary>
        [JsonProperty("UnionId")]
        public string UnionId{ get; set; }

        /// <summary>
        /// 微信昵称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 车系编号
        /// </summary>
        [JsonProperty("SeriesCode")]
        public string SeriesCode{ get; set; }

        /// <summary>
        /// 车型编号
        /// </summary>
        [JsonProperty("ModelCode")]
        public string ModelCode{ get; set; }

        /// <summary>
        /// 省份编号
        /// </summary>
        [JsonProperty("ProvinceCode")]
        public string ProvinceCode{ get; set; }

        /// <summary>
        /// 城市编号
        /// </summary>
        [JsonProperty("CityCode")]
        public string CityCode{ get; set; }

        /// <summary>
        /// 顾问名称
        /// </summary>
        [JsonProperty("SalesName")]
        public string SalesName{ get; set; }

        /// <summary>
        /// 顾问电话
        /// </summary>
        [JsonProperty("SalesPhone")]
        public string SalesPhone{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("TagList")]
        public string[] TagList{ get; set; }

        /// <summary>
        /// 客户姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClueId", this.ClueId);
            this.SetParamSimple(map, prefix + "DealerId", this.DealerId);
            this.SetParamSimple(map, prefix + "EnquireTime", this.EnquireTime);
            this.SetParamSimple(map, prefix + "UnionId", this.UnionId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "SeriesCode", this.SeriesCode);
            this.SetParamSimple(map, prefix + "ModelCode", this.ModelCode);
            this.SetParamSimple(map, prefix + "ProvinceCode", this.ProvinceCode);
            this.SetParamSimple(map, prefix + "CityCode", this.CityCode);
            this.SetParamSimple(map, prefix + "SalesName", this.SalesName);
            this.SetParamSimple(map, prefix + "SalesPhone", this.SalesPhone);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArraySimple(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
        }
    }
}

