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
        /// <p>环境别名。</p><h3 id=".E6.A0.BC.E5.BC.8F.E8.A6.81.E6.B1.82">格式要求</h3><ul><li>可选字符： 小写字母(a~z)、数字、减号(-)</li><li>不能以 减号(-) 开头或结尾</li><li>不能有连个连续的 减号(-)</li><li>长度不超过20位<br>示例值：cloud</li></ul>
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// <p>云开发环境套餐Id。<br>对于云开发环境套餐，可通过 <a href="https://cloud.tencent.com/document/product/876/78167">DescribeBaasPackageList</a> 接口获取，对应其出参的PackageName。</p>
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// <p>资源类型。代表新购环境时需要发货哪些资源。<br>可取值以及含义：</p><ul><li>flexdb : 表示文档型数据库</li><li>storage : 表示云存储</li><li>function : 表示云函数</li><li>postgresql：表示postgresql数据库</li></ul><p><strong>该字段不可为空</strong></p>
        /// </summary>
        [JsonProperty("Resources")]
        public string[] Resources{ get; set; }

        /// <summary>
        /// <p>购买实例的时长，单位：月。取值范围：1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 24。<br>默认值为1，即1个月。</p>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// <p>是否自动选择代金券支付。</p>
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public bool? AutoVoucher{ get; set; }

        /// <summary>
        /// <p>环境标签。<br>可取值通过接口 <a href="https://cloud.tencent.com/document/product/651/35316">tag:DescribeTags</a> 可获取到。<br>不传或为空则默认不打任何标签。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>自动续费标识。取值范围：</p><ul><li>NOTIFY_AND_AUTO_RENEW：通知过期且自动续费</li><li>NOTIFY_AND_MANUAL_RENEW：通知过期不自动续费（需要手动续费，可通过接口 <a href="https://cloud.tencent.com/document/product/876/128590">RenewEnv</a> 来续费）</li></ul><p>默认取值：NOTIFY_AND_MANUAL_RENEW。<br>若该参数指定为NOTIFY_AND_AUTO_RENEW（即：自动续费），在账户余额充足的情况下，实例到期后将按月自动续费；但如果账户余额不足，将无法自动续费。请留意腾讯云短信和邮件通知。</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// <p>云存储外部存储源。<br>表示该环境下不再自动分配云存储cos桶，而是由指定的bucket作为该环境的云存储介质。</p><p>仅当 Resources 中包含storage时有效。</p>
        /// </summary>
        [JsonProperty("ExternalStorage")]
        public ExternalStorage ExternalStorage{ get; set; }

        /// <summary>
        /// <p>开启或关闭 超限转按量。 可取值： TRUE/FALSE （字符串类型） 非法制、不传、为空 则不变更该字段。</p>
        /// </summary>
        [JsonProperty("EnableOverrun")]
        public string EnableOverrun{ get; set; }


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
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamObj(map, prefix + "ExternalStorage.", this.ExternalStorage);
            this.SetParamSimple(map, prefix + "EnableOverrun", this.EnableOverrun);
        }
    }
}

