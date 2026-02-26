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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEnvRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境别名。
        /// 
        /// ### 格式要求
        /// - 可选字符： 小写字母(a~z)、数字、减号(-)
        /// - 不能以 减号(-) 开头或结尾
        /// - 不能有连个连续的 减号(-)
        /// - 长度不超过20位
        /// 示例值：cloud
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 云开发环境套餐Id。
        /// 对于云开发环境套餐，可通过 [DescribeBaasPackageList](https://cloud.tencent.com/document/product/876/78167) 接口获取，对应其出参的PackageName。
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 资源类型。代表新购环境时需要发货哪些资源。
        /// 可取值以及含义：
        /// - flexdb : 表示文档型数据库
        /// - storage : 表示云存储
        /// - function : 表示云函数
        /// 
        /// **该字段不可为空**
        /// </summary>
        [JsonProperty("Resources")]
        public string[] Resources{ get; set; }

        /// <summary>
        /// 购买实例的时长，单位：月。取值范围：1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 24。
        /// 默认值为1，即1个月。
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 是否自动选择代金券支付。
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public bool? AutoVoucher{ get; set; }

        /// <summary>
        /// 环境标签。
        /// 可取值通过接口 [tag:DescribeTags](https://cloud.tencent.com/document/product/651/35316) 可获取到。
        /// 不传或为空则默认不打任何标签。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamArraySimple(map, prefix + "Resources.", this.Resources);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

